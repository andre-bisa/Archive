package fondt2.tlc.plans.tests;


import fondt2.tlc.plans.PhoneCall;
import fondt2.tlc.plans.PhonePlanOption;

public class MockOption extends PhonePlanOption {

	private double constCallCost;

	public MockOption(String name, double constCallCost) {
		super(name);
		this.constCallCost = constCallCost;
	}
	
	@Override
	public double getCallCost(PhoneCall call) {
		return this.constCallCost;
	}

}
