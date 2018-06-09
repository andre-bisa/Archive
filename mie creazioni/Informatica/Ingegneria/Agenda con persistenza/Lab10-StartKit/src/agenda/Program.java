package agenda;
import agenda.gui.controller.AgendaController;
import agenda.gui.controller.SwingViewFactory;
import agenda.gui.controller.ViewFactory;
import agenda.persistence.ContactsPersister;
import agenda.persistence.TextContactsPersister;

public class Program {
	public static void main(String[] args) {
		ViewFactory viewFactory = new SwingViewFactory();
		ContactsPersister contactsPersister = new TextContactsPersister();
		AgendaController controller = new AgendaController(viewFactory, contactsPersister);
		controller.showUI();
	}
}
