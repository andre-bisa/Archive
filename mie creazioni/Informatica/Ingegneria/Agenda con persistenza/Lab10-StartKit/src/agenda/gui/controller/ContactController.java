package agenda.gui.controller;

import agenda.domainModel.Contact;
import agenda.gui.utils.DialogResult;
import agenda.gui.view.InsertEditContactDialog;

public class ContactController {

	private ViewFactory viewFactory;

	public ContactController(ViewFactory viewFactory) {
		this.viewFactory = viewFactory;
	}

	public Contact insertContact() {
		Contact contact = new Contact();
		return editContact(contact) ? contact : null;
	}

	public boolean editContact(Contact contact) {
		InsertEditContactDialog view = viewFactory
				.createInsertEditContactDialog();
		view.setContact(contact);
		if (view.showDialog() == DialogResult.Ok) {
			view.updateContact(contact);
			return true;
		}
		return false;
	}
}
