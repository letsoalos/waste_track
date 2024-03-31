import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { AccountService } from './account/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  isLoggedIn: boolean = false;

  constructor(private accountService: AccountService) {} 

  ngOnInit(): void {
    this.loadCurrentUser();

    this.accountService.currentUser$.subscribe(user => {
      this.isLoggedIn = !!user;
    });
  }

  loadCurrentUser() {
    const token = localStorage.getItem('token');
    if (token) this.accountService.loadCurrentUser(token).subscribe();
  }
}

/*
  ngOnInit(): void {
    this.router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        this.isRegistrarRoute = this.router.url.includes('/registrar');
      }
    });    
  }
*/