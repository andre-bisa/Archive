/**
 * 
 */
package fondt2.tlc.plans;

import java.time.Duration;
import java.time.LocalDateTime;

/**
 * @author lab4_103
 *
 */
public class PrecisePlan extends PhonePlanAdapter {
	
	public PrecisePlan(String name, int intervalInMillis, double startCallCost, Rate[] rates) {
		super(name, intervalInMillis, startCallCost, rates);
	}

	@Override
	public double getCallCost(PhoneCall call) {
		double result = 0;
		
		Duration interval = Duration.ofMillis(this.getIntervalInMillis());
		
		for (LocalDateTime current = call.getStart(); current.isBefore(call.getEnd()); current = current.plus(interval)) {
			Rate currentRate = getRateByDestination(call.getDestNumber());
			result += currentRate.getCostPerInterval(current);
		}
		
		return result + this.startCallCost;
	}
	
}
