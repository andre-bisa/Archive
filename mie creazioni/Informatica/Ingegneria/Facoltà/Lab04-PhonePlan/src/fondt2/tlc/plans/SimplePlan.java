/**
 * 
 */
package fondt2.tlc.plans;

import java.time.Duration;

/**
 * @author lab4_103
 *
 */
public class SimplePlan extends PhonePlanAdapter {

	public SimplePlan(String name, int intervalInMillis, double startCallCost, Rate[] rates) {
		super(name, intervalInMillis, startCallCost, rates);
	}

	@Override
	public double getCallCost(PhoneCall call) {
		Rate selected = getRateByDestination(call.getDestNumber());
		if (selected == null) {
			return -1;
		}

		double costPerInterval = selected.getCostPerInterval(call.getStart());
		if (costPerInterval == -1) {
			return -1;
		}
		
		long difference = Duration.between(call.getStart(),  call.getEnd()).toMillis();
		int intervalCount = (int) (difference / intervalInMillis); // Ok divisione intera
		return startCallCost + intervalCount * costPerInterval;
	}

}
