import { Component, Input, Output, OnInit } from '@angular/core';
import { Restaurant } from './restaurant.model';

@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.component.html',
  styleUrls: ['./restaurant.component.css']
})
/** restaurant component*/
export class RestaurantComponent implements OnInit {

  @Input() restaurant: Restaurant
  /** restaurant ctor */
  constructor() {

  }
  ngOnInit(): void {
    //throw new Error("Method not implemented.");
  }
}
