﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class PacDotController
    {
        private PacDotModel pacDotModel;
        private PacDotUI pacDotUI;

        public PacDotController()
        {
            this.pacDotModel = new PacDotModel();
            this.pacDotUI = new PacDotUI();
        }

        // returns view
        public PacDotUI view
        {
            get
            {
                return this.pacDotUI;
            }
        }

        // executes when the observable is changed
        public void notify(bool isEaten)
        {

            // update view with images
            this.pacDotUI.updateImage(isEaten);


        }

    }
}