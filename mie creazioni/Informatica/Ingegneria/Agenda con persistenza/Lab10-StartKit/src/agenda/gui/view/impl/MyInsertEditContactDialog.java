package agenda.gui.view.impl;

import java.awt.Dimension;
import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JTextField;

import agenda.domainModel.Contact;
import agenda.gui.utils.FormDialog;
import agenda.gui.view.InsertEditContactDialog;

public class MyInsertEditContactDialog extends FormDialog implements
		InsertEditContactDialog {
	private static final long serialVersionUID = 1L;
	private JLabel firstNameLabel;
	private JLabel secondNameLabel;
	private JTextField firstNameTextBox;
	private JTextField secondNameTextBox;

	public MyInsertEditContactDialog() {
		super();
	}

	protected void initGUI() {
		setTitle("Inserimento/Modifica Contatto");
		GridLayout grid = new GridLayout(2, 2);
		getContentPanel().setLayout(grid);
		firstNameLabel = new JLabel("Nome");
		getContentPanel().add(firstNameLabel);
		firstNameTextBox = new JTextField();
		getContentPanel().add(firstNameTextBox);

		secondNameLabel = new JLabel("Cognome");
		getContentPanel().add(secondNameLabel);
		secondNameTextBox = new JTextField();
		getContentPanel().add(secondNameTextBox);

		this.setPreferredSize(new Dimension(400, 200));
		Center();
	}

	public void setContact(Contact model) {
		firstNameTextBox.setText(model.getFirstName());
		secondNameTextBox.setText(model.getSecondName());
	}

	public void updateContact(Contact model) {
		model.setFirstName(firstNameTextBox.getText());
		model.setSecondName(secondNameTextBox.getText());
	}
}
