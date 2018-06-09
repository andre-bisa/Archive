package agenda.gui.view;

import agenda.gui.controller.AgendaController;

public interface MainView {
	void setController(AgendaController controller);

	void showView();
}
