package fondt2.tlc.plans;

public abstract class PhonePlanOption implements PhonePlan {
	private String name;
	private PhonePlan next;
	
	protected PhonePlanOption(String name) {
		this.name = name;
	}
	
	@Override
	public String getName() {
		return this.name;
	}

	@Override
	public double getCallCost(PhoneCall call) {
		return getNext().getCallCost(call);
	}

	@Override
	public boolean isValid() {
		return getNext() != null && getNext().isValid();
	}

	public PhonePlan getNext() {
		return this.next;
	}

	public void setNext(PhonePlan next) {
		this.next = next;
	}
}
