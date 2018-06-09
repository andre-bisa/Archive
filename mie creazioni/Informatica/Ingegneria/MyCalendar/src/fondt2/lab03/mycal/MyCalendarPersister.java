/**
 * 
 */
package fondt2.lab03.mycal;

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.time.LocalDateTime;

/**
 * @author s0000753177
 *
 */
public class MyCalendarPersister implements Persister<AppointmentCollection> {
	final static String FILEPATH = "Calendar.bin"; 

	@Override
	public AppointmentCollection load() throws IOException {
		// in caso di errori non faccio nulla, risputo l'errore!

		try (ObjectInputStream input = new ObjectInputStream(Files.newInputStream(Paths.get(FILEPATH)))) {

			int dim = input.readInt(); // leggo la dim

			AppointmentCollection result = new AppointmentCollection(dim);

			for (int i = 0; i < dim; i++) {
				String description = null;
				LocalDateTime from = null;
				LocalDateTime to = null;

				description = (String) input.readObject();
				from = (LocalDateTime) input.readObject();
				to = (LocalDateTime) input.readObject();

				Appointment appuntamento = new Appointment(description, from, to);
				result.add(appuntamento); // aggiungo l'oggetto creato
			}
			return result;
		}
		catch (Exception e) {
			throw new IOException("Errore, file non conforme.");
		}
	}

	@Override
	public void save(AppointmentCollection appointments) throws IOException {
		try (ObjectOutputStream output = new ObjectOutputStream(Files.newOutputStream(Paths.get(FILEPATH), StandardOpenOption.CREATE))) {

			output.writeInt(appointments.size());
			
			for (int i = 0; i < appointments.size(); i++) {
				Appointment current = appointments.get(i);
				
				output.writeObject(current.getDescription());
				output.writeObject(current.getFrom());
				output.writeObject(current.getTo());
				
			}
			
		}
		catch (Exception e) {
			throw new IOException("Errore, file non conforme.");
		}
	}

}
