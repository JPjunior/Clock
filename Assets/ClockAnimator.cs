using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    private const float
    hoursToDegrees = 360 / 12f,
    minutesToDegrees = 360 / 60f,
    secondsToDegrees = 360 / 60f;
    public Transform hours, minutes, seconds;
    public bool analog;

        private void Update (){
        if (analog) {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
                hours.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
                minutes.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minutesToDegrees);
                seconds.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secondsToDegrees);
                }
            else {
            DateTime time = DateTime.Now;
                hours.localRotation =
                Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
                minutes.localRotation =
                Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
                seconds.localRotation =
                Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
                }
        }
}