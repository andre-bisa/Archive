/**
 * 
 */
package fondt2.tlc.plans.options;

import fondt2.tlc.plans.PhoneCall;
import fondt2.tlc.plans.PhonePlanOption;

/**
 * @author lab4_103
 *
 */
public class YouMeAndTheOther extends PhonePlanOption {
	private String destNumber1;
	private String destNumber2;
	private double constCost;
	
	public YouMeAndTheOther(String destNumber1, String destNumber2, double constCost) {
		super("You Me And The Other");
		this.destNumber1 = destNumber1;
		this.destNumber2 = destNumber2;
		this.constCost = constCost;
	}

	public String getDestNumber1() {
		return this.destNumber1;
	}

	public String getDestNumber2() {
		return this.destNumber2;
	}
	
	public double getConstCost() {
		return this.constCost;
	}
	
	public double getCallCost(PhoneCall call) {
		double cost = 0;
		
		if (call.getDestNumber().equals(this.getDestNumber1()) || (call.getDestNumber().equals(this.getDestNumber2()))) {
			cost = constCost;
		} else {
			cost = super.getCallCost(call);
		}
		
		return cost;
	}

	

}
