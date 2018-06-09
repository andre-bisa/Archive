package agenda.domainModel;

public class DetailFactory {
	private DetailFactory() {
	}

	public static String[] getNames() {
		return new String[] { "EMail", "Phone", "Address" };
	}

	public static Detail create(String name) {
		if (name.equals("EMail")) {
			return new EMail();
		} else if (name.equals("Phone")) {
			return new Phone();
		} else if (name.equals("Address")) {
			return new Address();
		}
		throw new IllegalArgumentException();
	}
}
