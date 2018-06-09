package fondt2.lab03.mycal;

import java.io.IOException;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;

public class MyCalendar implements CalendarController {
	private AppointmentCollection allAppointments;
	private Persister<AppointmentCollection> persister;

	public MyCalendar(Persister<AppointmentCollection> persister) {
		allAppointments = new AppointmentCollection(1000);

		this.persister = persister;

		//  carico da file
		try {
			AppointmentCollection read = persister.load();
			for (int i = 0; i < read.size(); i++) {
				allAppointments.add(read.get(i));
			}
		} catch (IOException e) {
			// il file non c'è, lo creo 
		}
	}

	// aggiungo un nuovo appuntamento
	/* (non-Javadoc)
	 * @see fondt2.lab03.mycal.CalendarController#add(fondt2.lab03.mycal.Appointment)
	 */
	@Override
	public boolean add(Appointment app) {
		int result = allAppointments.add(app);

		if (result >= 0) {
			// salvo
			try {
				persister.save(this.getAllAppointments());
			} catch (IOException e) {
				System.err.println("Errore salvataggio.");
			}
			return true;
		}

		return false;
	}

	/* (non-Javadoc)
	 * @see fondt2.lab03.mycal.CalendarController#remove(fondt2.lab03.mycal.Appointment)
	 */
	@Override
	public boolean remove(Appointment app) {
		int position = allAppointments.indexOf(app);
		if (position >= 0) {
			allAppointments.removeAt(position);
			// carico
			try {
				persister.save(this.getAllAppointments());
			} catch (IOException e) {
				System.err.println("Errore salvataggio.");
			}
			return true;
		}
		return false;
	}

	private boolean isOverlapped(LocalDateTime start, LocalDateTime end, 
			LocalDateTime refStart, LocalDateTime refEnd) {
		return !(end.isBefore(refStart) || start.isAfter(refEnd) || start.isEqual(refEnd));
		//		return (start.isAfter(refStart) || start.isEqual(refStart)) && start.isBefore(refEnd) ||
		//			   (end.isAfter(refStart) || end.isEqual(refStart)) && end.isBefore(refEnd) ||
		//			   (start.isBefore(refStart) && end.isAfter(refStart));
	}

	private AppointmentCollection getAppointmentsIn(LocalDateTime start, LocalDateTime end) {
		AppointmentCollection appList = new AppointmentCollection(
				allAppointments.size());
		for (int i = 0; i < allAppointments.size(); i++) {
			Appointment app = allAppointments.get(i);
			if (isOverlapped(app.getFrom(), app.getTo(), start, end)) {
				appList.add(app);
			}
		}
		return appList;
	}

	/* (non-Javadoc)
	 * @see fondt2.lab03.mycal.CalendarController#getDayAppointments(java.time.LocalDate)
	 */
	@Override
	public AppointmentCollection getDayAppointments(LocalDate date) {
		LocalDateTime dayStart = LocalDateTime.of(date, LocalTime.of(0, 0));
		LocalDateTime dayEnd = dayStart.plusDays(1);
		return getAppointmentsIn(dayStart, dayEnd);
	}

	/* (non-Javadoc)
	 * @see fondt2.lab03.mycal.CalendarController#getMonthAppointments(java.time.LocalDate)
	 */
	@Override
	public AppointmentCollection getMonthAppointments(LocalDate date) {
		LocalDate firstDayOfMonth = date.withDayOfMonth(1);
		LocalDateTime monthStart = LocalDateTime.of(firstDayOfMonth, LocalTime.of(0, 0));
		LocalDateTime monthEnd = monthStart.plusMonths(1);
		return getAppointmentsIn(monthStart, monthEnd);
	}

	/* (non-Javadoc)
	 * @see fondt2.lab03.mycal.CalendarController#getWeekAppointments(java.time.LocalDate)
	 */
	@Override
	public AppointmentCollection getWeekAppointments(LocalDate date) {
		long distanceFromPastMonday = date.getDayOfWeek().getValue() - DayOfWeek.MONDAY.getValue();
		LocalDate weekStartDate = date.minusDays(distanceFromPastMonday);
		LocalDateTime weekStart = LocalDateTime.of(weekStartDate, LocalTime.of(0, 0));
		LocalDateTime weekEnd = weekStart.plusWeeks(1);

		return getAppointmentsIn(weekStart, weekEnd);
	}

	/* (non-Javadoc)
	 * @see fondt2.lab03.mycal.CalendarController#getAllAppointments()
	 */
	@Override
	public AppointmentCollection getAllAppointments() {
		AppointmentCollection appCollection = new AppointmentCollection(
				allAppointments.size());
		for (int i = 0; i < allAppointments.size(); i++) {
			appCollection.add(allAppointments.get(i));
		}
		return appCollection;
	}

}
