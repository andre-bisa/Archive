package agenda.gui.controller;

import java.util.List;

import agenda.domainModel.Contact;
import agenda.domainModel.Detail;
import agenda.domainModel.DetailFactory;
import agenda.gui.utils.DialogResult;
import agenda.gui.view.DetailDialog;
import agenda.gui.view.InsertEditDetailDialog;
import agenda.gui.view.SelectDetailTypeDialog;
import agenda.gui.view.YesNoQuestionDialog;

public class DetailController {
	private Contact contact;
	private ViewFactory viewFactory;

	public DetailController(Contact contact, ViewFactory viewFactory) {
		this.contact = contact;
		this.viewFactory = viewFactory;
	}

	public void showUI() {
		DetailDialog view = viewFactory.createDetailDialog();
		view.setController(this);
		view.showDialog();
	}

	public Contact getContact() {
		return contact;
	}

	public List<Detail> getDetails() {
		return contact.getDetailList();
	}

	public boolean insertDetail() {
		SelectDetailTypeDialog selectTypeDetailView = viewFactory
				.createSelectDetailTypeDialog();
		selectTypeDetailView.setAvailableTypes(DetailFactory.getNames());
		if (selectTypeDetailView.showDialog() == DialogResult.Ok) {
			String type = selectTypeDetailView.getSelectedType();
			Detail detail = DetailFactory.create(type);
			InsertEditDetailDialog view = viewFactory
					.createInsertEditDetailDialog(type);
			view.setDetail(detail);
			if (view.showDialog() == DialogResult.Ok) {
				view.updateDetail(detail);
				contact.getDetailList().add(detail);
				return true;
			}
		}
		return false;
	}

	public boolean editDetail(Detail detail) {
		String type = detail.getName();
		InsertEditDetailDialog view = viewFactory
				.createInsertEditDetailDialog(type);
		view.setDetail(detail);
		if (view.showDialog() == DialogResult.Ok) {
			view.updateDetail(detail);
			return true;
		}
		return false;
	}

	public boolean deleteDetail(Detail detail) {
		if (contact != null) {
			YesNoQuestionDialog dialog = viewFactory.createYesNoQuestionDialog();
			DialogResult result = dialog.showQuestion("Conferma Eliminazione", 
					"Procedere con l'eliminazione?");
			
			if (result == DialogResult.Yes) {
				contact.getDetailList().remove(detail);
				return true;
			}
		}
		return false;
	}
}
