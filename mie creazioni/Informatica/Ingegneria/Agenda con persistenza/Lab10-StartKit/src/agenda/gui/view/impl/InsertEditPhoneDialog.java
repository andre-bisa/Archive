package agenda.gui.view.impl;

import java.awt.Dimension;
import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JTextField;

import agenda.domainModel.Detail;
import agenda.domainModel.Phone;
import agenda.gui.utils.FormDialog;
import agenda.gui.view.InsertEditDetailDialog;

public class InsertEditPhoneDialog extends FormDialog implements
		InsertEditDetailDialog {
	private static final long serialVersionUID = 1L;
	private JLabel phoneLabel;
	private JTextField phoneTextBox;
	private JLabel descriptionLabel;
	private JTextField descriptionTextbox;

	public InsertEditPhoneDialog() {
		super();
	}

	protected void initGUI() {
		setTitle("Inserisci/Modifica Telefono");
		GridLayout gridlayout = new GridLayout(2, 2);
		gridlayout.setHgap(30);
		gridlayout.setVgap(1);
		getContentPanel().setLayout(gridlayout);

		phoneLabel = new JLabel();
		phoneLabel.setText("Telefono: ");
		getContentPanel().add(phoneLabel);
		phoneTextBox = new JTextField();
		getContentPanel().add(phoneTextBox);

		descriptionLabel = new JLabel();
		descriptionLabel.setText("Descrizione: ");
		getContentPanel().add(descriptionLabel);
		descriptionTextbox = new JTextField();
		getContentPanel().add(descriptionTextbox);

		this.setPreferredSize(new Dimension(300, 180));
		Center();
	}

	@Override
	public void setDetail(Detail detail) {
		Phone phone = (Phone) detail;
		phoneTextBox.setText(phone.getValue());
		descriptionTextbox.setText(phone.getDescription());
	}

	@Override
	public void updateDetail(Detail detail) {
		Phone phone = (Phone) detail;
		phone.setValue(phoneTextBox.getText());
		phone.setDescription(descriptionTextbox.getText());
	}
}
