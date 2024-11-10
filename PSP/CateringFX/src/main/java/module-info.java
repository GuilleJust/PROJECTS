module com.example.cateringfx {
    requires javafx.controls;
    requires javafx.fxml;

    requires org.controlsfx.controls;
    requires java.desktop;

    opens com.example.cateringfx to javafx.fxml;
    exports com.example.cateringfx;
    exports CaterinFX.model;
    opens CaterinFX.model to javafx.fxml;
}

