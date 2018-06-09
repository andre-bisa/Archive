package agenda.gui.view;

import agenda.domainModel.Detail;
import agenda.gui.utils.DialogResult;

public interface InsertEditDetailDialog {
	void setDetail(Detail detail);

	void updateDetail(Detail detail);

	DialogResult showDialog();
}
