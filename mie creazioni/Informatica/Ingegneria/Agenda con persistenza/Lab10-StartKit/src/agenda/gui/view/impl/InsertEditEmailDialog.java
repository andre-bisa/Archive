package agenda.gui.view.impl;

import java.awt.Dimension;
import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JTextField;

import agenda.domainModel.Detail;
import agenda.domainModel.EMail;
import agenda.gui.utils.FormDialog;
import agenda.gui.view.InsertEditDetailDialog;

@SuppressWarnings("serial")
public class InsertEditEmailDialog extends FormDialog implements
		InsertEditDetailDialog {
	private JLabel emailLabel;
	private JTextField emailTextbox;
	private JLabel descriptionLabel;
	private JTextField descriptionTextbox;

	public InsertEditEmailDialog() {
		super();
	}

	@Override
	protected void initGUI() {
		setTitle("Inserisci/Modifica Email");
		GridLayout gridlayout = new GridLayout(2, 2);
		gridlayout.setHgap(30);
		gridlayout.setVgap(1);
		getContentPanel().setLayout(gridlayout);

		emailLabel = new JLabel();
		emailLabel.setText("Indirizzo e-mail: ");
		getContentPanel().add(emailLabel);
		emailTextbox = new JTextField();
		getContentPanel().add(emailTextbox);

		descriptionLabel = new JLabel();
		descriptionLabel.setText("Descrizione: ");
		getContentPanel().add(descriptionLabel);
		descriptionTextbox = new JTextField();
		getContentPanel().add(descriptionTextbox);

		this.setPreferredSize(new Dimension(300, 170));
		Center();
	}

	@Override
	public void setDetail(Detail detail) {
		EMail email = (EMail) detail;
		emailTextbox.setText(email.getValue());
		descriptionTextbox.setText(email.getDescription());
	}

	@Override
	public void updateDetail(Detail detail) {
		EMail email = (EMail) detail;
		email.setValue(emailTextbox.getText());
		email.setDescription(descriptionTextbox.getText());
	}
}
