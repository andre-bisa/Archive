package fondt2.lab03.mycal;

import java.time.LocalDate;

public interface CalendarController {

	// aggiungo un nuovo appuntamento
	public boolean add(Appointment app);

	public boolean remove(Appointment app);

	public AppointmentCollection getDayAppointments(LocalDate date);

	public AppointmentCollection getMonthAppointments(LocalDate date);

	public AppointmentCollection getWeekAppointments(LocalDate date);

	public AppointmentCollection getAllAppointments();

}