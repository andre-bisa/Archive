package fondt2.tlc.plans.tests;

import static org.junit.Assert.*;

import java.time.*;

import org.junit.Test;

import fondt2.tlc.plans.rates.Band;

public class BandTest {
	
	@Test
	public void testIsInBand() {
		Band band = new Band(LocalTime.of(10, 0), LocalTime.of(12, 0),
				new DayOfWeek[] { DayOfWeek.MONDAY, DayOfWeek.TUESDAY }, 10);
		
		LocalDateTime dateTime = LocalDateTimeHelper.getLocalDateTimeWith(22, 22, DayOfWeek.WEDNESDAY);
		assertFalse(band.isInBand(dateTime));
		
		dateTime = LocalDateTimeHelper.getLocalDateTimeWith(11, 22, DayOfWeek.TUESDAY);
		assertTrue(band.isInBand(dateTime));
		
		dateTime = LocalDateTimeHelper.getLocalDateTimeWith(9, 22, DayOfWeek.MONDAY);
		assertFalse(band.isInBand(dateTime));
	}

	@Test
	public void testIsValid() {
		Band band = new Band(LocalTime.of(10, 0), LocalTime.of(12, 0),
				new DayOfWeek[] { DayOfWeek.MONDAY, DayOfWeek.TUESDAY }, 10);
		assertTrue(band.isValid());
	}

	@Test
	public void testIsNotValid1() {
		Band band = new Band(LocalTime.of(10, 0), LocalTime.of(12, 0),
				new DayOfWeek[0], 10);
		assertFalse(band.isValid());
	}

	@Test
	public void testIsNotValid2() {
		Band band = new Band(LocalTime.of(12, 0), LocalTime.of(10, 0),
				new DayOfWeek[] { DayOfWeek.MONDAY, DayOfWeek.TUESDAY }, 10);
		assertFalse(band.isValid());
	}

}
