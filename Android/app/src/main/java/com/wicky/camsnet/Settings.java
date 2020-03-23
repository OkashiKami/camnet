package com.wicky.camsnet;

import android.os.Handler;
import android.view.View;
import android.widget.EditText;

import androidx.annotation.NonNull;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

class Settings implements View.OnClickListener {
    private static final String TAG = "Settings";
    private final MainActivity activity;
    private DatabaseReference db;
    public final View view;

    private EditText ip_et;
    private EditText port_et;
    private Integer cameraX;
    private Integer cameraY;
    private Integer cameraZ;

    public Settings(MainActivity activity, View v) {
        this.activity = activity;
        this.view = v;
        db = FirebaseDatabase.getInstance().getReference();
        view.findViewById(R.id.exit_settings).setOnClickListener(this);
        view.findViewById(R.id.submit_settings).setOnClickListener(this);
        ip_et = view.findViewById(R.id.ip_et);
        port_et = view.findViewById(R.id.port_et);
        LoadSettings();
    }


    private void LoadSettings() {
        db.child("camsnet/settings/ip").addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                ip_et.setText(dataSnapshot.getValue(String.class));
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });
        db.child("camsnet/settings/port").addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                port_et.setText(dataSnapshot.getValue(String.class));
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });

        db.child("camsnet/settings/xAxis").addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                cameraX = dataSnapshot.getValue(Integer.class);
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });
        db.child("camsnet/settings/yAxis").addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                cameraY = dataSnapshot.getValue(Integer.class);
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });
        db.child("camsnet/settings/zAxis").addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                cameraZ = dataSnapshot.getValue(Integer.class);
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });
    }
    private void SaveSettings(){
       db.child("camsnet/settings/ip").setValue(ip_et.getText().toString());
       db.child("camsnet/settings/port").setValue(port_et.getText().toString());
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
