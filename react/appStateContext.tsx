import React, { useReducer } from 'react';
import { IUserAuthToken } from '../pages/login'
import { ActionType, action } from 'typesafe-actions';

// Represents the structure of the application state
interface IAppState {
    authenticated: boolean;
    userAuthToken?: IUserAuthToken;
    jwtToken: string;
}

// List of actions available in the application state
export const SetIsAuthenticated = (value: boolean) => action(`IS_AUTHENTICATED`, value);
export const setLogOut = () => action(`LOG_OUT`);
export const setLogin = () => action('LOGIN');
export const setJWTToken = (jwtToken: string) => action('UPDATE_JWT_TOKEN', `Bearer ${jwtToken}`);

const ActionTypes = {
    SetIsAuthenticated, setLogOut, setLogin, setJWTToken
}


type AppStateActions = ActionType<typeof ActionTypes>


export const initialAppState: IAppState = { authenticated: false, jwtToken: '' };

// @TODO enable action type
export const AppStateReducer = (state: IAppState, action: AppStateActions): IAppState => {
    switch (action.type) {
        case 'IS_AUTHENTICATED':
            return { ...state, authenticated: action.payload };
        case 'LOG_OUT':
            return { ...state, authenticated: false }
        case 'LOGIN':
            return { ...state, authenticated: true }
        case 'UPDATE_JWT_TOKEN':
            debugger;
            return { ...state, jwtToken: action.payload }
        default:
            return state;
    }
}

const defaultDispatch: React.Dispatch<AppStateActions> = () => initialAppState;

export const AppStateContext: React.Context<[IAppState, React.Dispatch<AppStateActions>]> = React.createContext([initialAppState, defaultDispatch]);






---------------------use-------------------------
import React, { useReducer, useState } from 'react';
import { AcivityDashboard } from './ui/pages/activityDashboard'
import { Login } from './ui/pages/login'
import { AppStateContext, AppStateReducer, initialAppState } from './ui/context/context';

const App: React.FC = () => {

  return (
    <AppStateContext.Provider value={useReducer(AppStateReducer, initialAppState)}>
      <AppStateContext.Consumer>
        {value => (!value[0].authenticated ? <Login /> : <AcivityDashboard />)}
      </AppStateContext.Consumer>
    </AppStateContext.Provider>
  );
}
export default App;
----------------------------------------------------------

-----------------------READ-------------------------------
const [appState, updateAppState] = useContext(AppStateContext);
   const jwt = appState.jwtToken;

