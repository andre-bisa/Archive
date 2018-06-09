/**
 * 
 */
package fondt2.lab03.mycal.tests;

import java.io.IOException;

import fondt2.lab03.mycal.AppointmentCollection;
import fondt2.lab03.mycal.Persister;

/**
 * @author s0000753177
 *
 */
class MockCalendarPersister implements Persister<AppointmentCollection> {

	@Override
	public AppointmentCollection load() throws IOException {
		throw new IOException("Mock");
	}

	@Override
	public void save(AppointmentCollection appointments) throws IOException {
	}

}
