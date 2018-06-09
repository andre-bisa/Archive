package fondt2.tlc.plans.tests;

import fondt2.tlc.plans.PhoneCall;
import fondt2.tlc.plans.PhonePlan;

public class MockPhonePlan implements PhonePlan {
	
	private String name;
	private double callCost;
	
	private int methodGetNameCallCount;
	private int methodGetCallCostCallCount;

	public MockPhonePlan(String name, double callCost) {
		this.name = name;
		this.callCost = callCost;
	}

	@Override
	public String getName() {
		methodGetNameCallCount++;
		return name;
	}
	
	public int getMethodGetNameCallCount() {
		return this.methodGetNameCallCount;
	}

	@Override
	public double getCallCost(PhoneCall call) {
		methodGetCallCostCallCount++;
		return callCost;
	}
	
	public int getMethodGetCallCostCallCount() {
		return this.methodGetCallCostCallCount;
	}

	@Override
	public boolean isValid() {
		return true;
	}

}
