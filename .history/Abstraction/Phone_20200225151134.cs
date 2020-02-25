using System;
public class Phone
{
    private bool powerOn;
    private bool goHomeScreen;
    private int volume;

    public togglePower()
    {
        if (powerOn)
        {
            this.volume = 0;
            this.goHomeScreen = false;
            powerOn = false;
        }
        else
        {
            powerOn = true;
            this.volume = 10;
            this.goHomeScreen = true;
        }
    }
}
/*
As user of the phone you only had access
to the togglePower() method. But under the
togglePower() method there is much going on
that the user cannot see.
*/
