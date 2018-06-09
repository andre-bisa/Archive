package fondt2.tlc.plans;

public class PhonePlanWithOptions implements PhonePlan {
	private PhonePlan actualPhonePlan;
	private PhonePlan chainHead;

	public PhonePlanWithOptions(PhonePlan actualPhonePlan) {
		this.actualPhonePlan = actualPhonePlan;
		this.chainHead = actualPhonePlan;
	}

	public void addOption(PhonePlanOption option) {
		option.setNext(chainHead);
		chainHead = option;
	}

	public boolean removeOption(PhonePlanOption option) {
		PhonePlanOption current = getHeadAsOption();
		
		if (current == null)
			return false;
		
		if (current.equals(option)) {
			chainHead = current.getNext();
			return true;
		}
		
		PhonePlanOption prev = current;
		current = getAsOption(current.getNext());
		while (current != null) {
			if (current.equals(option)) {
				prev.setNext(current.getNext());
				return true;
			}
			current = getAsOption(current.getNext());
		}
		return false;
	}

	public boolean removeOptionByName(String optionName) {
		PhonePlanOption current = getHeadAsOption();
		
		if (current == null)
			return false;
		
		if (current.getName().equals(optionName)) {
			chainHead = current.getNext();
			return true;
		}
		PhonePlanOption prev = current;
		current = getAsOption(current.getNext());
		while (current != null) {
			String nameOfCurrent = current.getName();
			if (nameOfCurrent.equals(optionName)) {
				prev.setNext(current.getNext());
				return true;
			}
			current = getAsOption(current.getNext());
		}
		return false;
	}

	@Override
	public String getName() {
		PhonePlanOption current = getHeadAsOption();
		String name = "";
		while (current != null) {
			name += " [Opt: " + current.getName() + "]";
			current = getAsOption(current.getNext());
		}
		return actualPhonePlan.getName() + name;
	}

	@Override
	public double getCallCost(PhoneCall call) {
		return chainHead.getCallCost(call);
	}

	@Override
	public boolean isValid() {
		return chainHead.isValid();
	}
	
	private PhonePlanOption getAsOption(PhonePlan plan) {
		return plan instanceof PhonePlanOption
				? (PhonePlanOption) plan
				: null;
	}
	
	private PhonePlanOption getHeadAsOption() {
		return getAsOption(chainHead);
	}

}
