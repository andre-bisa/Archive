package fondt2.tlc.plans.rates;

import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.LocalTime;

import fondt2.tlc.plans.Rate;

public abstract class BandsRate implements Rate {
	private String name;
	private Band[] bands;

	public BandsRate(String name, Band[] bands) {
		this.name = name;
		this.bands = bands;
	}

	@Override
	public abstract boolean isApplicableTo(String number);

	@Override
	public String getName() {
		return name;
	}

	public Band[] getBands() {
		return bands;
	}

	@Override
	public double getCostPerInterval(LocalDateTime dateTime) {
		for (Band b : bands) {
			if (b.isInBand(dateTime)) {
				return b.getCostPerInterval();
			}
		}
		return -1;
	}

	public boolean isValid() {
		for (Band band : bands) {
			if (!band.isValid()) {
				return false;
			}
		}
		for (DayOfWeek day : DayOfWeek.values()) {
			if (!validateDay(day)) {
				return false;
			}
		}
		return true;
	}

	private boolean validateDay(DayOfWeek day) {
		if (day != null) {
			Band[] bandsInDay = selectBandsInDay(day);
			sortBandsByStartTime(bandsInDay);
			return validateBandsInDay(bandsInDay);
		} else {
			return false;
		}
	}

	private boolean validateBandsInDay(Band[] bandsInDay) {
		// Le bande devono essere adiacenti e coprire l'intera giornata
		// L'ordinamento serve per semplificare l'algoritmo di controllo
		for (int i = 0; i < bandsInDay.length - 1; i++) {
			LocalTime firstBandEndTime = bandsInDay[i].getEndTime();
			LocalTime secondBandStartTime = bandsInDay[i + 1].getStartTime();
			
			if (!firstBandEndTime.plusNanos(1).equals(secondBandStartTime)) {
				return false;
			}
		}
		return bandsInDay.length > 0
				&& bandsInDay[0].getStartTime().equals(LocalTime.MIN)
				&& bandsInDay[bandsInDay.length - 1].getEndTime().equals(
						LocalTime.MAX);
	}

	private Band[] selectBandsInDay(DayOfWeek day) {
		int count = 0;
		for (Band band : bands) {
			if (DayOfWeekHelper.isDayIn(day, band.getCombinedDays())) {
				count++;
			}
		}

		Band[] result = new Band[count];
		int j = 0;
		for (int i = 0; i < bands.length; i++) {
			if (DayOfWeekHelper.isDayIn(day, bands[i].getCombinedDays())) {
				result[j++] = bands[i];
			}
		}

		return result;
	}

	public void sortBandsByStartTime(Band[] bands) {
		for (int i = 0; i < bands.length; i++) {
			for (int j = i + 1; j < bands.length; j++) {
				if (bands[i].getStartTime().compareTo(bands[j].getStartTime()) > 0) {
					Band temp = bands[i];
					bands[i] = bands[j];
					bands[j] = temp;
				}
			}
		}
	}
}
