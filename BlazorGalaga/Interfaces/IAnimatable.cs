﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using BlazorGalaga.Models;
using static BlazorGalaga.Models.Sprite;

namespace BlazorGalaga.Interfaces
{
    public interface IAnimatable 
    {
        public int Index { get; set; }
        public PointF Location { get; set; }
        public PointF PevLocation { get; set; }
        public PointF NextLocation { get; set; }
        public List<BezierCurve> Paths { get; set; }
        public bool RotateAlongPath { get; set; }
        public bool DrawPath { get; set; }
        public Sprite Sprite { get; set; }
        public List<Sprite> SpriteBank { get; set; }
        public bool PathIsLine { get; set; }
        public List<PointF> PathPoints { get; set; }
        public int CurPathPointIndex { get; set; }
        public float Rotation { get; set; }
        public int Speed { get; set; }
        public bool DrawControlLines { get; set; }
        public int StartDelay { get; set; }
        public bool StartDelayStarted { get; set; }
        public bool Started { get; set; }
        public bool IsMoving { get; set; }
        public int? SpriteBankIndex { get; set; }
        public int ZIndex { get; set; }
        public int RotatIntoPlaceSpeed { get; set; }
        public Vector2 LineFromLocation { get; set; }
        public Vector2 LineToLocation { get; set; }
        public float LastLineToLocationDistance { get; set; }
        public bool DestroyAfterComplete { get; set; }
        public bool DestroyImmediately { get; set; }
        public bool Visible { get; set; }
        public List<VSpeed> VSpeed { get; set; }
        public bool DoLineToLocation { get; set; }
        public float LastDelayTimeStamp { get; set; }
        public bool AllowNegativeSpeed { get; set; }
        public bool RotateWhileStill { get; set; }
        public bool PathDrawn { get; set; }
        public float ManualRotation { get; set; }
        public float ManualRotationRate { get; set; }
        public bool IsMovingDown { get; set; }
        public bool NeverDestroyOffScreen { get; set; }

    }
}
