import { Component, OnInit } from '@angular/core';
import { MainService } from 'src/app/main.service';

@Component({
  selector: 'app-vr-home',
  templateUrl: './vr-home.component.html',
  styleUrls: ['./vr-home.component.scss']
})
export class VrHomeComponent implements OnInit{
  constructor(private srv: MainService){

  }
  ngOnInit(): void {
    //this.srv.setPageNameOption('card-issuer');
  }

}
