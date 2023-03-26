﻿using ReactiveUI;
using System;
using System.Reactive;

namespace DZ6.Models {
    public class ShapeListBoxItem {
        public ShapeListBoxItem(string name, Mapper map) {
            Name = name;
            Remove = ReactiveCommand.Create<Unit, Unit>(_ => { map.Remove(this); return new Unit(); });
        }

        public string Name { get; }

        public ReactiveCommand<Unit, Unit> Remove { get; }
    }
}
