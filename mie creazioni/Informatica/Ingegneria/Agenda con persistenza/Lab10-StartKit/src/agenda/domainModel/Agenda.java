package agenda.domainModel;

import java.util.*;

public class Agenda {
	private Set<Contact> contactSet;

	public Agenda() {
		contactSet = new TreeSet<Contact>();
	}
	
	public Agenda(Collection<Contact> contacts) {
		contactSet = new TreeSet<Contact>(contacts);
	}

	public Set<Contact> getContacts() {
		return contactSet;
	}

	public Contact getContact(String firstName, String secondName) {
		for (Contact contact : getContacts()) {
			if (contact.getFirstName().equals(firstName)
					&& contact.getSecondName().equals(secondName))
				return contact;
		}
		return null;
	}

	public Contact getContact(int index) {
		int i = 0;
		for (Contact contact : getContacts()) {
			if (i == index)
				return contact;
			i++;
		}
		return null;
	}

	public Set<Contact> searchContacts(String secondName) {
		TreeSet<Contact> contacts = new TreeSet<Contact>();
		for (Contact c : getContacts()) {
			if (c.getSecondName().toLowerCase()
					.contains(secondName.toLowerCase()))
				contacts.add(c);
		}
		return contacts;
	}
}
