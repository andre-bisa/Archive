package agenda.gui.view.impl;

import java.awt.Dimension;
import java.awt.GridLayout;

import javax.swing.DefaultComboBoxModel;
import javax.swing.JComboBox;
import javax.swing.JLabel;

import agenda.gui.utils.FormDialog;
import agenda.gui.view.SelectDetailTypeDialog;

@SuppressWarnings("serial")
public class MySelectDetailTypeDialog extends FormDialog implements
		SelectDetailTypeDialog {
	private JLabel typeLabel;
	private JComboBox<String> typeCombo;

	public MySelectDetailTypeDialog() {
		super();
	}

	protected void initGUI() {
		setTitle("Seleziona il tipo di Dettaglio");
		GridLayout gridlayout = new GridLayout(1, 2);
		gridlayout.setHgap(30);
		gridlayout.setVgap(1);
		getContentPanel().setLayout(gridlayout);

		typeLabel = new JLabel();
		typeLabel.setText("Tipo di Dettaglio: ");
		getContentPanel().add(typeLabel);
		typeCombo = new JComboBox<String>();
		getContentPanel().add(typeCombo);

		this.setPreferredSize(new Dimension(300, 150));
		Center();
	}

	@Override
	public void setAvailableTypes(String[] elements) {
		DefaultComboBoxModel<String> model = (DefaultComboBoxModel<String>) typeCombo
				.getModel();
		for (String element : elements) {
			model.addElement(element);
		}
	}

	@Override
	public String getSelectedType() {
		return (String) typeCombo.getSelectedItem();
	}
}
