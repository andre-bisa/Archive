/**
 * 
 */
package fondt2.tlc.plans.options;

import java.time.LocalDateTime;

import fondt2.tlc.plans.PhoneCall;
import fondt2.tlc.plans.PhonePlanOption;

/**
 * @author lab4_103
 *
 */
public class FlatTime extends PhonePlanOption {
	private int flatPeriod;

	public FlatTime(int flatPeriod) {
		super("Flat Time");
		this.flatPeriod = flatPeriod;
	}

	public double getCallCost(PhoneCall call) {
		for (LocalDateTime current = call.getStart(); current.isBefore(call.getEnd()); current = current.plusMinutes(1)) {
			if (this.getFlatPeriod() > 0) 
				flatPeriod--;
			else {
				PhoneCall remainingCall = new PhoneCall(current, call.getEnd(), call.getDestNumber());
				return super.getCallCost(remainingCall);
			}
		}
		return 0;
	}

	public int getFlatPeriod() {
		return this.flatPeriod;
	}

}
