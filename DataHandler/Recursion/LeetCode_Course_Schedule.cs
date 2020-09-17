
//problem : https://leetcode.com/problems/course-schedule/

public class Solution {
    
    bool dfs( int u , List<int>[] graph, ref Dictionary<int,int> visit){
        if(visit[u] == 2)return true ;
        visit[u] = 1 ;
        bool res = true ;
        for(int i=0 ; i<graph[u].Count ; i++){
            int v = graph[u][i] ;
            if(visit[v] == 1)return false ;
            if(visit[v] == 0)res&=dfs(v, graph, ref visit) ;
        }
        visit[u] = 2 ;
        return res ;
    }
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        //var visit = new List<int>(numCourses) ;
        var visit = new Dictionary<int,int>() ;
        var map =  new Dictionary<int,int>() ;
        var graph = new List<int>[numCourses] ;
        int id = 0 ;
        for(int i=0 ; i<numCourses;  i++){
            graph[i] = new List<int>() ;
            visit.Add(i, 0) ;
            map.Add(i,id++) ;
        }
        
        
        
        for(int i=0 ; i<prerequisites.Length ; i++){
            int u = prerequisites[i][1] ;
            int v = prerequisites[i][0] ;
            if(!map.ContainsKey(u))map.Add(u,id++) ;
            if(!map.ContainsKey(v))map.Add(v,id++) ;
            graph[map[u]].Add(map[v]) ;
        }
        bool res = true ;
        for(int i=0 ; i<numCourses ; i++){
            if(visit.ContainsKey(i) && visit[i]==0)res&=dfs(map[i] ,  graph, ref visit) ;
        }
        
        return res ;
    }
}