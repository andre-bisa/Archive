package agenda.gui.view.impl;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.IOException;
import java.util.Set;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.WindowConstants;

import agenda.domainModel.Contact;
import agenda.gui.controller.AgendaController;
import agenda.gui.utils.JBindableTable;
import agenda.gui.view.MainView;

public class MainFrame extends JFrame implements ActionListener, MainView {
	private static final long serialVersionUID = 1L;
	private JPanel searchPanel;
	private JButton deleteButton;
	private JButton detailButton;
	private JButton editButton;
	private JButton insertButton;
	private JButton saveButton;
	private JButton openButton;
	private JPanel buttonPanel;
	private JButton searchButton;
	private JTextField searchTextbox;
	private AgendaController controller;
	private JBindableTable<Contact> table;

	public MainFrame() {
		initGUI();
		pack();
	}

	protected void initGUI() {
		try {
			setTitle("Agenda");

			setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
			{
				table = new JBindableTable<Contact>(Contact.class);
				getContentPane().add(table, BorderLayout.CENTER);
			}
			{
				buttonPanel = new JPanel();
				getContentPane().add(buttonPanel, BorderLayout.WEST);
				GridLayout buttonPanelLayout = new GridLayout(6, 1);
				buttonPanelLayout.setColumns(1);
				buttonPanelLayout.setHgap(5);
				buttonPanelLayout.setVgap(5);
				buttonPanelLayout.setRows(6);
				buttonPanel.setLayout(buttonPanelLayout);
				buttonPanel.setPreferredSize(new java.awt.Dimension(150, 319));
				{
					openButton = new JButton();
					buttonPanel.add(openButton);
					openButton.setText("Apri...");
					openButton
							.setIcon(new ImageIcon(getClass().getClassLoader()
									.getResource("resources/Open.png")));
					openButton.addActionListener(this);
				}
				{
					saveButton = new JButton();
					buttonPanel.add(saveButton);
					saveButton.setText("Salva");
					saveButton
							.setIcon(new ImageIcon(getClass().getClassLoader()
									.getResource("resources/Save.png")));
					saveButton.addActionListener(this);
				}
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
					detailButton = new JButton();
					buttonPanel.add(detailButton);
					detailButton.setText("Dettagli...");
					detailButton.addActionListener(this);
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
			{
				searchPanel = new JPanel();
				FlowLayout searchPanelLayout = new FlowLayout();
				searchPanelLayout.setAlignment(FlowLayout.RIGHT);
				searchPanel.setLayout(searchPanelLayout);
				getContentPane().add(searchPanel, BorderLayout.NORTH);
				{
					searchTextbox = new JTextField();
					searchPanel.add(searchTextbox);
					searchTextbox.setPreferredSize(new java.awt.Dimension(309,
							23));
				}
				{
					searchButton = new JButton();
					searchPanel.add(searchButton);
					searchButton.setText("Cerca");
					searchButton.addActionListener(this);
				}
			}
			pack();
			setExtendedState(MAXIMIZED_BOTH);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		Object source = e.getSource();
		if (source == openButton)
			onOpenClick();
		if (source == saveButton)
			onSaveClick();
		if (source == insertButton)
			onInsertClick();
		if (source == deleteButton)
			onDeleteClick();
		if (source == editButton)
			onEditClick();
		if (source == searchButton)
			onSearchClick();
		if (source == detailButton)
			onDetailClick();
	}

	private void onDetailClick() {
		if (table.getSelectedItem() != null)
			controller.showDetails(table.getSelectedItem());
	}

	private void onSearchClick() {
		Set<Contact> contacts = controller.search(searchTextbox.getText());
		showContacts(contacts);
	}

	private void onEditClick() {
		if (table.getSelectedItem() != null
				&& controller.editContact(table.getSelectedItem())) {
			showAllContacts();
		}
	}

	private void onDeleteClick() {
		if (table.getSelectedItem() != null
				&& controller.deleteContact(table.getSelectedItem())) {
			showAllContacts();
		}
	}

	private void onInsertClick() {
		if (controller.insertContact()) {
			showAllContacts();
		}
	}

	private void onSaveClick() {
		controller.save();
	}

	private void onOpenClick() {
		JFileChooser chooser = new JFileChooser();
		try {
			File f = new File(new File(".").getCanonicalPath());
			chooser.setCurrentDirectory(f);
		} catch (IOException e) {
		}
		int returnValue = chooser.showOpenDialog(this);
		if (returnValue == JFileChooser.APPROVE_OPTION) {
			File file = chooser.getSelectedFile();
			controller.loadContacts(file.getPath());
			showAllContacts();
		}
	}

	private void showContacts(Set<Contact> contacts) {
		table.dataBind(contacts);
	}

	private void showAllContacts() {
		showContacts(controller.getAll());
	}

	@Override
	public void setController(AgendaController controller) {
		this.controller = controller;
		showAllContacts();
	}

	@Override
	public void showView() {
		setVisible(true);
	}
}
