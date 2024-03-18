import { AfterContentInit, Component, OnInit } from '@angular/core';
import { MainService } from 'src/app/main.service';

@Component({
  selector: 'app-vr-home',
  templateUrl: './vr-home.component.html',
  styleUrls: ['./vr-home.component.scss']
})
export class VrHomeComponent implements OnInit, AfterContentInit{
  constructor(private srv: MainService){

  }
  ngOnInit(): void {
   
  }

  ngAfterContentInit (): void{
    //this.srv.setPageNameOption('verifier');
  }

}
