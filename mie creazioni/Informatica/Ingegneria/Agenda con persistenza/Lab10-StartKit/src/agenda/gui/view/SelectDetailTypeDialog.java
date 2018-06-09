package agenda.gui.view;

import agenda.gui.utils.DialogResult;

public interface SelectDetailTypeDialog {
	void setAvailableTypes(String[] types);

	String getSelectedType();

	DialogResult showDialog();
}
