package agenda.gui.view;

import agenda.domainModel.Contact;
import agenda.gui.utils.DialogResult;

public interface InsertEditContactDialog {
	void setContact(Contact contact);

	void updateContact(Contact contact);

	DialogResult showDialog();
}
