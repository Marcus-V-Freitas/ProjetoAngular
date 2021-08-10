import { Component, OnInit } from '@angular/core';
import { RestaurantsService } from '../restaurants/restaurants.service';
import { Restaurant } from '../restaurant/restaurant.model';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-restaurant-detail',
  templateUrl: './restaurant-detail.component.html',
  styleUrls: ['./restaurant-detail.component.css']
})
/** restaurant-detail component*/
export class RestaurantDetailComponent implements OnInit {
  /** restaurant-detail ctor */

  restaurant: Restaurant

  constructor(private restaurantService: RestaurantsService, private route: ActivatedRoute) {

  }
  ngOnInit(): void {

    this.restaurantService.restaurantById(this.route.snapshot.params['id'])
      .subscribe(restaurant => this.restaurant = restaurant);
  }


}
