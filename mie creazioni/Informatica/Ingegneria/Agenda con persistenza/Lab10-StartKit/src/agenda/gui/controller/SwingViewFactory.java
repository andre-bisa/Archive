package agenda.gui.controller;

import agenda.gui.view.DetailDialog;
import agenda.gui.view.InsertEditContactDialog;
import agenda.gui.view.InsertEditDetailDialog;
import agenda.gui.view.MainView;
import agenda.gui.view.MessageDialog;
import agenda.gui.view.SelectDetailTypeDialog;
import agenda.gui.view.YesNoQuestionDialog;
import agenda.gui.view.impl.InsertEditAddressDialog;
import agenda.gui.view.impl.InsertEditEmailDialog;
import agenda.gui.view.impl.InsertEditPhoneDialog;
import agenda.gui.view.impl.MainFrame;
import agenda.gui.view.impl.MyDetailDialog;
import agenda.gui.view.impl.MyInsertEditContactDialog;
import agenda.gui.view.impl.MySelectDetailTypeDialog;
import agenda.gui.view.impl.OptionPaneMessageDialog;

public class SwingViewFactory implements ViewFactory {
	@Override
	public MainView createMainView() {
		MainView mainFrame = new MainFrame();
		return mainFrame;
	}

	@Override
	public SelectDetailTypeDialog createSelectDetailTypeDialog() {
		SelectDetailTypeDialog view = new MySelectDetailTypeDialog();
		return view;
	}
	
	@Override
	public InsertEditDetailDialog createInsertEditDetailDialog(
			String type) {
		if (type.equals("Phone"))
			return new InsertEditPhoneDialog();
		if (type.equals("Address"))
			return new InsertEditAddressDialog();
		if (type.equals("EMail"))
			return new InsertEditEmailDialog();
		throw new IllegalArgumentException();
	}

	@Override
	public InsertEditContactDialog createInsertEditContactDialog() {
		InsertEditContactDialog view = new MyInsertEditContactDialog();
		return view;
	}

	@Override
	public DetailDialog createDetailDialog() {
		DetailDialog view = new MyDetailDialog();
		return view;
	}

	@Override
	public MessageDialog createMessageDialog() {
		return new OptionPaneMessageDialog();
	}

	@Override
	public YesNoQuestionDialog createYesNoQuestionDialog() {
		return new OptionPaneMessageDialog();
	}
}
