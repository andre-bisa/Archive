package fondt2.tlc.plans.tests;

import static org.junit.Assert.*;

import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.LocalTime;

import org.junit.Test;

import fondt2.tlc.plans.Rate;
import fondt2.tlc.plans.rates.Band;
import fondt2.tlc.plans.rates.DestinationOperatorBandRate;

public class DestinationOperatorBandRateTest {

	public static Rate createRate() {
		DayOfWeek[] workWeek = new DayOfWeek[] { DayOfWeek.MONDAY,
				DayOfWeek.TUESDAY, DayOfWeek.WEDNESDAY, DayOfWeek.THURSDAY,
				DayOfWeek.FRIDAY };
		DayOfWeek[] weekEnd = new DayOfWeek[] { DayOfWeek.SATURDAY,
				DayOfWeek.SUNDAY };
		Band[] bands = new Band[] {
				new Band(LocalTime.MIN, LocalTime.MAX, weekEnd, 10),
				new Band(LocalTime.of(0, 0), LocalTime.of(8, 0).minusNanos(1), workWeek, 10),
				new Band(LocalTime.of(8, 0), LocalTime.of(18, 30).minusNanos(1), workWeek, 20),
				new Band(LocalTime.of(18, 30), LocalTime.MAX, workWeek, 10) 
				};
		return new DestinationOperatorBandRate("Verso TIM", bands, "TIM");
	}

	public static Rate createInvalidRate() {
		DayOfWeek[] workWeek = new DayOfWeek[] { DayOfWeek.MONDAY,
				DayOfWeek.TUESDAY, DayOfWeek.WEDNESDAY, DayOfWeek.THURSDAY,
				DayOfWeek.FRIDAY };
		DayOfWeek[] weekEnd = new DayOfWeek[] { DayOfWeek.SATURDAY,
				DayOfWeek.SUNDAY };
		Band[] bands = new Band[] {
				new Band(LocalTime.MIN, LocalTime.MAX, weekEnd,
						10),
				new Band(LocalTime.MIN, LocalTime.of(8, 0).minusNanos(1), workWeek,
						10),
				new Band(LocalTime.of(8, 0), LocalTime.of(18, 0).minusNanos(1),
						workWeek, 20) };
		return new DestinationOperatorBandRate("Verso TIM", bands, "TIM");
	}

	@Test
	public void testGetCostPerInterval() {
		LocalDateTime dateTime = LocalDateTimeHelper.getLocalDateTimeWith(22, 22, DayOfWeek.WEDNESDAY);
		double actual = createRate().getCostPerInterval(dateTime);
		assertEquals(10, actual, 0.01);
	}

	@Test
	public void testIsValid() {
		assertTrue(createRate().isValid());
	}

	@Test
	public void testNotValid() {
		assertFalse(createInvalidRate().isValid());
	}
}
