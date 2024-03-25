import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {
  showWastePickerButton: boolean = false;
  showCooperateButton: boolean = false;
  showVerifierButton: boolean = false;
  showVerifierEditButton: boolean = false;

  constructor(private router: Router) { }

  ngOnInit(): void {
    console.log('SidebarComponent initialized.');
    this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
        const currentUrl = this.router.url;
        console.log('Current URL:', currentUrl);
        this.showWastePickerButton = currentUrl.startsWith('/registrar/waste-picker');
        this.showCooperateButton = currentUrl.startsWith('/registrar/cooperate');
        this.showVerifierButton = currentUrl.startsWith('/verifier');
        this.showVerifierEditButton = currentUrl.startsWith('/verifier');
        console.log('Show Waste Picker Button:', this.showWastePickerButton);
        console.log('Show Cooperate Button:', this.showCooperateButton);
        console.log('Show Verifier Button:', this.showVerifierButton);
      }
    });
  }  
}
