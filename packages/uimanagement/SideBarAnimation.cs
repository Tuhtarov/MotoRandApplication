using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using System.Windows.Threading;

namespace MotoRandApplication.packages.uimanagement
{
    class SideBarAnimation
    {
        private double gridWidth;
        private bool gridIsHidden;

        private TextBlock TextMenu;
        private Grid grid;
        private DispatcherTimer timer;
        private Effect shadowEffectStockValue;
        private DropShadowEffect shadowEffectNull;



        public SideBarAnimation(Grid grid, TextBlock textMenu)
        {
            gridWidth = grid.Width;
            InitTicker();
            InitNullShadowEffect();
            this.grid = grid;
            shadowEffectStockValue = grid.Effect;
            this.TextMenu = textMenu;
            SideStart();
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (gridIsHidden)
            {
                grid.Width += 15;
                TextMenu.Opacity += 0.2;
                if (grid.Width >= gridWidth)
                {
                    gridIsHidden = false;
                    timer.Stop();
                }
            }
            else
            {
                grid.Width -= 15;
                TextMenu.Opacity -= 0.2;
                if (grid.Width <= 50)
                {
                    gridIsHidden = true;
                    timer.Stop();
                }
            }
        }

        private void InitTicker()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            timer.Tick += OnTick;
        }

        private void ChangeShadowEffect()
        {
            if (!gridIsHidden)
            {
                grid.Effect = shadowEffectNull;
            }
            else
            {
                grid.Effect = shadowEffectStockValue;
            }
        }

        private void InitNullShadowEffect()
        {
            shadowEffectNull = new DropShadowEffect();
            shadowEffectNull.Opacity = 0;
            shadowEffectNull.BlurRadius = 0;
            shadowEffectNull.ShadowDepth = 0;
        }

        public void SideStart()
        {
            timer.Start();
            ChangeShadowEffect();
        }
    }
}
