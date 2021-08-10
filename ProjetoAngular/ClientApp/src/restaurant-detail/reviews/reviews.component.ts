import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'
import { RestaurantsService } from '../../restaurants/restaurants.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-reviews',
  templateUrl: './reviews.component.html',
  styleUrls: ['./reviews.component.css']
})
/** reviews component*/
export class ReviewsComponent implements OnInit {

  reviews: Observable<any>
  /** reviews ctor */
  constructor(private restaurantsService: RestaurantsService,
    private route: ActivatedRoute) {
  }

  ngOnInit() {
    this.reviews = this.restaurantsService.reviewsOfRestaurant(this.route.snapshot.params['id']);
  }
}
