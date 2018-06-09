/**
 * 
 */
package fondt2.tlc.plans;

/**
 * @author lab4_103
 *
 */
public abstract class PhonePlanAdapter implements PhonePlan {
	protected String name;
	protected int intervalInMillis;
	protected double startCallCost;
	protected Rate[] rates;
	
	protected PhonePlanAdapter(String name, int intervalInMillis, double startCallCost, Rate[] rates) {
		this.name = name;
		this.intervalInMillis = intervalInMillis;
		this.startCallCost = startCallCost;
		this.rates = rates.clone();
	}
	
	public int getIntervalInMillis() {
		return intervalInMillis;
	}

	public double getStartCallCost() {
		return startCallCost;
	}
	
	protected Rate getRateByDestination(String destinationNumber) {
		for (Rate currentRate : this.rates) {
			if (currentRate.isApplicableTo(destinationNumber)) {
				return currentRate;
			}
		}
		return null;
	}

	@Override
	public abstract double getCallCost(PhoneCall call);

	@Override
	public String getName() {
		return this.name;
	}

	@Override
	public boolean isValid() {
		for (Rate currentRate : this.rates) {
			if (! currentRate.isValid())
				return false;
		}
		return true;
	}

}
