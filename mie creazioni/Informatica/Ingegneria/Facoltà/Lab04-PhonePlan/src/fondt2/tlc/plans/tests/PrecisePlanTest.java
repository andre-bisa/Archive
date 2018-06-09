/**
 * 
 */
package fondt2.tlc.plans.tests;

import static org.junit.Assert.*;

import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.Month;

import org.junit.Test;

import fondt2.tlc.plans.PhoneCall;
import fondt2.tlc.plans.PrecisePlan;
import fondt2.tlc.plans.Rate;
import fondt2.tlc.plans.rates.DayOfWeekHelper;

/**
 * @author lab4_103
 *
 */
public class PrecisePlanTest {

	@Test
	public void testGetCallCost() {
		Rate[] rates = new Rate[] {new MockPreciseRate(1)};

		LocalDateTime callStart = LocalDateTime.of(2016, Month.APRIL, 16, 23, 55, 00); // 16/04/2016 23:55:00
		LocalDateTime callEnd = callStart.plusMinutes(10); // 17/04/2016 00:05:00
		PhoneCall call = new PhoneCall(callStart, callEnd, "0123456789");

		PrecisePlan plan = new PrecisePlan("Name", 1000, 0, rates);
		double actual = 300;
		assertEquals(actual, plan.getCallCost(call) , 0);
	}

	@Test
	public void testPrecisePlan() {
		Rate[] rates = new Rate[] {new MockRate(), new MockRate()};
		PrecisePlan plan = new PrecisePlan("Name", 1000, 10, rates);
		assertEquals(1000, plan.getIntervalInMillis());
		assertEquals("Name", plan.getName());
	}

}
