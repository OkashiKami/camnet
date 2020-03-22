package comwicky.camsnet;

import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.ToggleButton;

import androidx.annotation.NonNull;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.firestore.DocumentReference;
import com.google.firebase.firestore.DocumentSnapshot;
import com.google.firebase.firestore.FirebaseFirestore;

import java.util.HashMap;
import java.util.Map;

class Settings implements View.OnClickListener {
    private static final String TAG = "Settings";
    private final MainActivity activity;
    private FirebaseFirestore db;
    private final View view;

    private EditText ip_et;
    private EditText port_et;
    private ToggleButton tcp_toggle;

    public Settings(MainActivity activity, View view) {
        this.activity = activity;
        this.view = view;
        db = FirebaseFirestore.getInstance();
        view.findViewById(R.id.exit_settings).setOnClickListener(this);
        view.findViewById(R.id.submit_settings).setOnClickListener(this);

        ip_et = view.findViewById(R.id.ip_et);
        port_et = view.findViewById(R.id.port_et);
        tcp_toggle = view.findViewById(R.id.useTcp_toggle);
        LoadSettings();
    }

    private void LoadSettings() {
        DocumentReference docRef = db.collection("camsnet").document("settings");
        docRef.get().addOnCompleteListener(new OnCompleteListener<DocumentSnapshot>() {
            @Override
            public void onComplete(@NonNull Task<DocumentSnapshot> task) {
                if (task.isSuccessful()) {
                    DocumentSnapshot document = task.getResult();
                    if (document.exists()) {
                        ip_et.setText((String)document.get("ip"));
                        port_et.setText((String)document.get("port"));
                        tcp_toggle.setChecked((Boolean)document.get("tcp"));
                    } else {
                        Log.d(TAG, "No such document");
                    }
                } else {
                    Log.d(TAG, "get failed with ", task.getException());
                }
            }
        });
    }
    private void SaveSettings(){
        DocumentReference docRef = db.collection("camsnet").document("settings");

        Map<String, Object> properties = new HashMap<>();
        properties.put("ip", ip_et.getText().toString());
        properties.put("port", port_et.getText().toString());
        properties.put("tcp", tcp_toggle.isChecked());
        docRef.set(properties);
    }

    @Override
    public void onClick(View v) {
        switch (v.getId())
        {
            case R.id.exit_settings:
                activity.setViewStub(-1);
                break;
            case R.id.submit_settings:
                SaveSettings();
                activity.setViewStub(-1);
                break;
        }
    }
}
