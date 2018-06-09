package agenda.gui.view.impl;

import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JTextField;

import agenda.domainModel.Address;
import agenda.domainModel.Detail;
import agenda.gui.utils.FormDialog;
import agenda.gui.view.InsertEditDetailDialog;

public class InsertEditAddressDialog extends FormDialog implements
		InsertEditDetailDialog {
	private static final long serialVersionUID = 1L;
	private JLabel descriptionLabel;
	private JLabel streetLabel;
	private JLabel numberLabel;
	private JLabel zipCodeLabel;
	private JLabel cityLabel;
	private JLabel stateLabel;
	private JTextField descriptionTextBox;
	private JTextField streetTextBox;
	private JTextField numberTextBox;
	private JTextField zipCodeTextBox;
	private JTextField cityTextBox;
	private JTextField stateTextBox;

	public InsertEditAddressDialog() {
		super();
	}

	@Override
	protected void initGUI() {
		setTitle("Inserisci/Modifica Indirizzo");
		GridLayout grid = new GridLayout(6, 2);
		getContentPanel().setLayout(grid);

		descriptionLabel = new JLabel("Descrizione");
		getContentPanel().add(descriptionLabel);
		descriptionTextBox = new JTextField();
		getContentPanel().add(descriptionTextBox);

		streetLabel = new JLabel("Strada");
		getContentPanel().add(streetLabel);
		streetTextBox = new JTextField();
		getContentPanel().add(streetTextBox);

		numberLabel = new JLabel("Numero");
		getContentPanel().add(numberLabel);
		numberTextBox = new JTextField();
		getContentPanel().add(numberTextBox);

		zipCodeLabel = new JLabel("CAP");
		getContentPanel().add(zipCodeLabel);
		zipCodeTextBox = new JTextField();
		getContentPanel().add(zipCodeTextBox);

		cityLabel = new JLabel("Città:");
		getContentPanel().add(cityLabel);
		cityTextBox = new JTextField();
		getContentPanel().add(cityTextBox);

		stateLabel = new JLabel("Stato");
		getContentPanel().add(stateLabel);
		stateTextBox = new JTextField();
		getContentPanel().add(stateTextBox);

		this.setSize(400, 350);
	}

	@Override
	public void setDetail(Detail detail) {
		Address model = (Address) detail;
		descriptionTextBox.setText(model.getDescription());
		streetTextBox.setText(model.getStreet());
		numberTextBox.setText(model.getNumber());
		cityTextBox.setText(model.getCity());
		stateTextBox.setText(model.getState());
		zipCodeTextBox.setText(model.getZipCode());
	}

	@Override
	public void updateDetail(Detail detail) {
		Address model = (Address) detail;
		model.setStreet(streetTextBox.getText());
		model.setNumber(numberTextBox.getText());
		model.setCity(cityTextBox.getText());
		model.setState(stateTextBox.getText());
		model.setZipCode(zipCodeTextBox.getText());
		model.setDescription(descriptionTextBox.getText());
	}
}
