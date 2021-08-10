import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../restaurant/restaurant.model';
import { RestaurantsService } from './restaurants.service';

@Component({
  selector: 'app-restaurants',
  templateUrl: './restaurants.component.html',
  styleUrls: ['./restaurants.component.css']
})
/** restaurants component*/
export class RestaurantsComponent implements OnInit {

  restaurants: Restaurant[]
  /** restaurants ctor */
  constructor(private restaurantService: RestaurantsService) {

  }
  ngOnInit(): void {
    this.restaurantService.restaurants().subscribe(restaurants => this.restaurants = restaurants);
  }
}
