package fondt2.lab03.mycal;

public class AppointmentCollection{
	private Appointment[] innerArray;
	private int logicalSize;

	public AppointmentCollection(int capacity) {
		innerArray = new Appointment[capacity];
		logicalSize = 0;
	}

	public int add(Appointment appointment) {
		int position = -1;
		if (logicalSize < innerArray.length) {
			position = logicalSize;
			innerArray[position] = appointment;
			logicalSize++;
		}
		return position;
	}

	public int indexOf(Appointment appointment) {
		for (int i = 0; i < logicalSize; i++) {
			if (get(i).equals(appointment)) {
				return i;
			}
		}
		return -1;
	}

	public void removeAt(int index) {
		if (index >= 0 && index < logicalSize) {
			for (int i = index; i < logicalSize - 1; i++) {
				innerArray[i] = innerArray[i + 1];
			}
			logicalSize--;
		}
	}

	public int size() {
		return logicalSize;
	}

	public Appointment get(int index) {
		if (index >= 0 && index < logicalSize) {
			return innerArray[index];
		}
		return null;
	}

}
