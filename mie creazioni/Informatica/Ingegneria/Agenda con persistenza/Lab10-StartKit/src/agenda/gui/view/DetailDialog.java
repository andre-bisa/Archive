package agenda.gui.view;

import agenda.gui.controller.DetailController;
import agenda.gui.utils.DialogResult;

public interface DetailDialog {
	void setController(DetailController controller);

	DialogResult showDialog();
}
