package com.wicky.camsnet;

import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.os.Handler;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.view.ViewStub;
import android.widget.RelativeLayout;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private boolean bottom_menu;
    List<View> options = new ArrayList<>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        getSupportActionBar().hide();
        findViewById(R.id.more).setOnClickListener(this);


        setupButton(R.id.option1, R.drawable.ic_wifi_white_24dp, new View.OnClickListener() {
            @Override
            public void onClick(View v){
                Toast.makeText(MainActivity.this, "Streaming Started...", Toast.LENGTH_LONG).show();
            }
        });
        setupButton(R.id.option4, R.drawable.ic_settings_black_24dp, new View.OnClickListener() {
            @Override
            public void onClick(View v){
                setViewStub(R.layout.activity_settings);
            }
        });

    }

    public void setViewStub(@Nullable int layout) {
        RelativeLayout rl = findViewById(R.id.include);
        rl.removeAllViews();

        if(layout <= 0) return;

        ViewStub vs = new ViewStub(this);
        rl.addView(vs);
        RelativeLayout.LayoutParams params = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MATCH_PARENT, RelativeLayout.LayoutParams.MATCH_PARENT);
        vs.setLayoutParams(params);

        switch (layout)
        {
            case R.layout.activity_settings:
                vs.setLayoutResource(layout);
                View view = vs.inflate();
                new Settings(this, view);
                break;
            default:
                Toast.makeText(this, "No layout was given.", Toast.LENGTH_SHORT).show(); break;
        }

        if(layout > -1) {



        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();


        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {

            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onClick(View v) {
        switch (v.getId())
        {
            case R.id.more:
                if(!bottom_menu) ShowMore(); else HideMore();
                break;
        }
    }

    private void ShowMore() {
       new Handler().post(new Runnable() {
           @Override
           public void run() {
               try {
                   for (int i = 0; i < options.size(); i++) {
                       options.get(i).setVisibility(View.VISIBLE);
                       Thread.sleep(100);
                   }
                   bottom_menu = true;
               }
               catch (Exception ex)
               {
                   ex.printStackTrace();
               }
           }
       });
    }
    private void HideMore() {
       new Handler().post(new Runnable() {
           @Override
           public void run() {
               try {
                   for (int i = 0; i < options.size(); i++) {
                       options.get(i).setVisibility(View.GONE);
                       Thread.sleep(100);
                   }
                   bottom_menu = false;
               }
               catch (Exception ex)
               {
                   ex.printStackTrace();
               }
           }
       });

    }

    public void setupButton(int id, int imageid,  @Nullable final View.OnClickListener l) {
        FloatingActionButton view = (FloatingActionButton) findViewById(id);
        view.setImageDrawable(getDrawable(imageid));
        view.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                HideMore();
                if(l != null)
                    l.onClick(v);
            }
        });
        options.add(view);

    }

}