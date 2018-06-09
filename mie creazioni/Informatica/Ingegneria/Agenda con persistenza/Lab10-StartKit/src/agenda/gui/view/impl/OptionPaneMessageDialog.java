package agenda.gui.view.impl;

import javax.swing.JOptionPane;

import agenda.gui.utils.DialogResult;
import agenda.gui.view.MessageDialog;
import agenda.gui.view.YesNoQuestionDialog;

public class OptionPaneMessageDialog implements MessageDialog, YesNoQuestionDialog {

	@Override
	public void showMessage(String title, String message) {
		JOptionPane.showMessageDialog(null, message, title, JOptionPane.OK_OPTION);
	}

	@Override
	public DialogResult showQuestion(String title, String message) {
		int response = JOptionPane.showConfirmDialog(null, message, title,
				JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
		return response == JOptionPane.YES_OPTION ? DialogResult.Yes : DialogResult.No;
	}

}
