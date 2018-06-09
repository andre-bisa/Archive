package fondt2.tlc.plans.rates;

import java.time.DayOfWeek;

public class DayOfWeekHelper {
	public static boolean isDayIn(DayOfWeek day, DayOfWeek[] combinedDays) {
		for (DayOfWeek d : combinedDays) {
			if (d == day) return true;
		}
		return false;
	}
}
