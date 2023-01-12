import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IPaginationProduct } from './models/paginationProduct';
import { IProduct } from './models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  
  title = 'Artegy App';
  
  //creation d'un tableau vide de advs
  advs: any[] | undefined;
  constructor(private http:HttpClient){}
  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/artegyadvs?pageSize=50').subscribe((response:any) => {
             this.advs = response.data;
    }, error => {
      console.log(error);
    });
    
    
  }
  
}
