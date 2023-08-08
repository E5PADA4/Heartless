using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeroicArcade.CC.Core {

    public class final_activate_wfc : MonoBehaviour {

        final_mill mainLevel;
        final_activate_floor activateFloor;
        final_activate_barrier activateBarrier;
        final_activate_platform activatePlatform;
        final_activate_spike activateSpike;

        public int floorProperty;
        public int barrierProperty;
        public int platformProperty;
        public int spikeProperty;
        
        void Start() {
            mainLevel = GameObject.Find("Final BK Manager").GetComponent<final_mill>();

            activateFloor = gameObject.GetComponentInChildren<final_activate_floor>();
            activateBarrier = gameObject.GetComponentInChildren<final_activate_barrier>();
            activatePlatform = gameObject.GetComponentInChildren<final_activate_platform>();
            activateSpike = gameObject.GetComponentInChildren<final_activate_spike>();
        }

        public void wfc() {
            floorProperty = activateFloor.initiate_floor(mainLevel.difficulty);
            barrierProperty = activateBarrier.initiate_barrier(mainLevel.difficulty);
            platformProperty = activatePlatform.initiate_platform(mainLevel.difficulty);
            spikeProperty = activateSpike.initiate_spike(mainLevel.difficulty);
        }
    }
}