import { Component, OnInit } from '@angular/core';
import { Restaurant } from 'src/app/Interfaces/restaurant';

@Component({
  selector: 'app-add-restaurants',
  templateUrl: './add-restaurants.component.html',
  styleUrls: ['./add-restaurants.component.css']
})
export class AddRestaurantsComponent implements OnInit {
  ngOnInit(): void {
    this.AddResta();
  }
  AddResta(new_rest:Restaurant){

  }



  

}
