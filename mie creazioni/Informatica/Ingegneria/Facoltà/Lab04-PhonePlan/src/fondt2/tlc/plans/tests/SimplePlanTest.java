package fondt2.tlc.plans.tests;

import static org.junit.Assert.*;

import java.time.LocalDateTime;

import org.junit.Test;

import fondt2.tlc.plans.PhoneCall;
import fondt2.tlc.plans.Rate;
import fondt2.tlc.plans.SimplePlan;

public class SimplePlanTest {

	@Test
	public void testGetCallCost() {
		fail("Not yet implemented");
	}

	@Test
	public void testSimplePlan() {
		Rate[] rates = new Rate[] {new MockRate()};
		SimplePlan plan = new SimplePlan("Nome", 1000, 1, rates);
		LocalDateTime callStart = LocalDateTime.now();
		LocalDateTime callEnd = callStart.plusMinutes(1);
		PhoneCall call = new PhoneCall(callStart, callEnd, "0123456789");
		
		double expected = 1 + 60*1;
		assertEquals(expected, plan.getCallCost(call), 0);
		
	}

}
