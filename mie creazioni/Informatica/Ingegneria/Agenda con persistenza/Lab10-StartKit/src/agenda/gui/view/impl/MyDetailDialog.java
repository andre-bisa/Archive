package agenda.gui.view.impl;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.WindowConstants;

import agenda.domainModel.Contact;
import agenda.domainModel.Detail;
import agenda.gui.controller.DetailController;
import agenda.gui.utils.FormDialog;
import agenda.gui.utils.JBindableTable;
import agenda.gui.view.DetailDialog;

public class MyDetailDialog extends FormDialog implements ActionListener,
		DetailDialog {
	private static final long serialVersionUID = 1L;
	private JButton deleteButton;
	private JButton editButton;
	private JButton insertButton;
	private JPanel buttonPanel;
	private DetailController controller;
	private JBindableTable<Detail> table;

	public MyDetailDialog() {
	}

	@Override
	protected void initGUI() {
		try {
			setPreferredSize(new Dimension(800, 400));
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			{
				table = new JBindableTable<Detail>(Detail.class);
				getContentPane().add(table, BorderLayout.CENTER);
			}
			{
				buttonPanel = new JPanel();
				getContentPane().add(buttonPanel, BorderLayout.WEST);
				GridLayout buttonPanelLayout = new GridLayout(3, 1);
				buttonPanelLayout.setColumns(1);
				buttonPanelLayout.setHgap(5);
				buttonPanelLayout.setVgap(5);
				buttonPanel.setLayout(buttonPanelLayout);
				{
					insertButton = new JButton();
					buttonPanel.add(insertButton);
					insertButton.setText("Inserisci");
					insertButton
							.setIcon(new ImageIcon(getClass().getClassLoader()
									.getResource("resources/New.png")));
					insertButton.addActionListener(this);
				}
				{
					editButton = new JButton();
					buttonPanel.add(editButton);
					editButton.setText("Modifica");
					editButton
							.setIcon(new ImageIcon(getClass().getClassLoader()
									.getResource("resources/Edit.png")));
					editButton.addActionListener(this);
				}
				{
					deleteButton = new JButton();
					buttonPanel.add(deleteButton);
					deleteButton.setText("Elimina");
					deleteButton.setIcon(new ImageIcon(getClass()
							.getClassLoader().getResource(
									"resources/Delete.png")));
					deleteButton.addActionListener(this);
				}
			}
			setCancelButtonVisible(false);
			Center();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		super.actionPerformed(e);
		Object source = e.getSource();
		if (source == insertButton)
			OnInsertClick();
		if (source == deleteButton)
			OnDeleteClick();
		if (source == editButton)
			OnEditClick();
	}

	private void updateDetails() {
		Contact contact = controller.getContact();
		setTitle(contact.getFirstName() + " " + contact.getSecondName());
		table.dataBind(controller.getDetails());
	}

	private void OnEditClick() {
		if (table.getSelectedItem() != null
				&& controller.editDetail(table.getSelectedItem())) {
			updateDetails();
		}
	}

	private void OnDeleteClick() {
		if (table.getSelectedItem() != null
				&& controller.deleteDetail(table.getSelectedItem())) {
			updateDetails();
		}
	}

	private void OnInsertClick() {
		if (controller.insertDetail()) {
			updateDetails();
		}
	}

	@Override
	public void setController(DetailController controller) {
		this.controller = controller;
		updateDetails();
	}
}
