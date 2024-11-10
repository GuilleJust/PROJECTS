module com.example.cardclient {
    requires javafx.controls;
    requires javafx.fxml;

    requires org.controlsfx.controls;
    requires com.dlsc.formsfx;
    requires org.kordamp.bootstrapfx.core;
    requires CardModel;

    opens com.example.cardclient to javafx.fxml;
    exports com.example.cardclient;
}